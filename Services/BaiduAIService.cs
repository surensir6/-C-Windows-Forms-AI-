using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Web.Script.Serialization;
using AIRecognitionTool.Models;

namespace AIRecognitionTool.Services
{
    /// <summary>
    /// 百度AI服务类
    /// </summary>
    public class BaiduAIService
    {
        private readonly string _apiKey;
        private readonly string _secretKey;
        private readonly HttpClient _httpClient;
        private string _accessToken;
        private DateTime _tokenExpiry;

        public BaiduAIService()
        {
            _apiKey = ConfigurationManager.AppSettings["BaiduApiKey"];
            _secretKey = ConfigurationManager.AppSettings["BaiduSecretKey"];
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(30);
        }

        /// <summary>
        /// 获取访问令牌
        /// </summary>
        private async Task<string> GetAccessTokenAsync()
        {
            if (!string.IsNullOrEmpty(_accessToken) && DateTime.Now < _tokenExpiry)
            {
                return _accessToken;
            }

            var url = $"https://aip.baidubce.com/oauth/2.0/token?grant_type=client_credentials&client_id={_apiKey}&client_secret={_secretKey}";
            
            try
            {
                var response = await _httpClient.GetStringAsync(url);
                var serializer = new JavaScriptSerializer();
                var tokenData = serializer.DeserializeObject(response) as Dictionary<string, object>;
                
                _accessToken = tokenData["access_token"]?.ToString();
                var expiresIn = Convert.ToInt32(tokenData["expires_in"] ?? 3600);
                _tokenExpiry = DateTime.Now.AddSeconds(expiresIn - 300); // 提前5分钟更新

                return _accessToken;
            }
            catch (Exception ex)
            {
                throw new Exception($"获取访问令牌失败: {ex.Message}");
            }
        }

        /// <summary>
        /// 将图片转换为Base64字符串
        /// </summary>
        private string ImageToBase64(Image image)
        {
            using (var memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                var imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        /// <summary>
        /// 车型识别
        /// </summary>
        public async Task<RecognitionResult> RecognizeVehicleAsync(Image image)
        {
            var result = new RecognitionResult();
            var startTime = DateTime.Now;

            try
            {
                var token = await GetAccessTokenAsync();
                var base64Image = ImageToBase64(image);

                var url = $"https://aip.baidubce.com/rest/2.0/image-classify/v1/car?access_token={token}";
                
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("image", base64Image),
                    new KeyValuePair<string, string>("top_num", "5")
                });

                var response = await _httpClient.PostAsync(url, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var serializer = new JavaScriptSerializer();
                    var jsonResult = serializer.DeserializeObject(responseContent) as Dictionary<string, object>;
                    
                    if (jsonResult.ContainsKey("result"))
                    {
                        var results = jsonResult["result"] as object[];
                        foreach (var item in results)
                        {
                            var itemDict = item as Dictionary<string, object>;
                            result.Results.Add(new RecognitionItem
                            {
                                Name = itemDict.ContainsKey("name") ? itemDict["name"]?.ToString() : "",
                                Confidence = itemDict.ContainsKey("score") ? Convert.ToDouble(itemDict["score"] ?? 0) : 0,
                                Description = $"车型: {(itemDict.ContainsKey("name") ? itemDict["name"]?.ToString() : "未知")}"
                            });
                        }
                        result.Success = true;
                        result.Message = "识别成功";
                    }
                    else
                    {
                        result.Success = false;
                        result.Message = jsonResult.ContainsKey("error_msg") ? jsonResult["error_msg"]?.ToString() : "识别失败";
                    }
                }
                else
                {
                    result.Success = false;
                    result.Message = $"请求失败: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"识别异常: {ex.Message}";
            }

            result.ProcessTime = (DateTime.Now - startTime).TotalMilliseconds;
            return result;
        }

        /// <summary>
        /// 车牌识别
        /// </summary>
        public async Task<RecognitionResult> RecognizeLicensePlateAsync(Image image)
        {
            var result = new RecognitionResult();
            var startTime = DateTime.Now;

            try
            {
                var token = await GetAccessTokenAsync();
                var base64Image = ImageToBase64(image);

                var url = $"https://aip.baidubce.com/rest/2.0/ocr/v1/license_plate?access_token={token}";
                
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("image", base64Image)
                });

                var response = await _httpClient.PostAsync(url, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var serializer = new JavaScriptSerializer();
                    var jsonResult = serializer.DeserializeObject(responseContent) as Dictionary<string, object>;
                    
                    if (jsonResult.ContainsKey("words_result"))
                    {
                        var plateInfo = jsonResult["words_result"] as Dictionary<string, object>;
                        result.Results.Add(new RecognitionItem
                        {
                            Name = plateInfo["number"]?.ToString(),
                            Confidence = Convert.ToDouble(plateInfo["probability"] ?? 0),
                            Description = $"车牌号: {plateInfo["number"]}, 颜色: {plateInfo["color"]}"
                        });
                        result.Success = true;
                        result.Message = "识别成功";
                    }
                    else
                    {
                        result.Success = false;
                        result.Message = jsonResult.ContainsKey("error_msg") ? jsonResult["error_msg"]?.ToString() : "识别失败";
                    }
                }
                else
                {
                    result.Success = false;
                    result.Message = $"请求失败: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"识别异常: {ex.Message}";
            }

            result.ProcessTime = (DateTime.Now - startTime).TotalMilliseconds;
            return result;
        }

        /// <summary>
        /// 菜品识别
        /// </summary>
        public async Task<RecognitionResult> RecognizeDishAsync(Image image)
        {
            var result = new RecognitionResult();
            var startTime = DateTime.Now;

            try
            {
                var token = await GetAccessTokenAsync();
                var base64Image = ImageToBase64(image);

                var url = $"https://aip.baidubce.com/rest/2.0/image-classify/v2/dish?access_token={token}";
                
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("image", base64Image),
                    new KeyValuePair<string, string>("top_num", "5")
                });

                var response = await _httpClient.PostAsync(url, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var serializer = new JavaScriptSerializer();
                    var jsonResult = serializer.DeserializeObject(responseContent) as Dictionary<string, object>;
                    
                    if (jsonResult.ContainsKey("result"))
                    {
                        var results = jsonResult["result"] as object[];
                        foreach (var item in results)
                        {
                            var itemDict = item as Dictionary<string, object>;
                            var calorie = itemDict.ContainsKey("calorie") ? itemDict["calorie"]?.ToString() : "未知";
                            result.Results.Add(new RecognitionItem
                            {
                                Name = itemDict["name"]?.ToString(),
                                Confidence = Convert.ToDouble(itemDict["probability"] ?? 0),
                                Description = $"菜品: {itemDict["name"]}, 热量: {calorie}"
                            });
                        }
                        result.Success = true;
                        result.Message = "识别成功";
                    }
                    else
                    {
                        result.Success = false;
                        result.Message = jsonResult.ContainsKey("error_msg") ? jsonResult["error_msg"]?.ToString() : "识别失败";
                    }
                }
                else
                {
                    result.Success = false;
                    result.Message = $"请求失败: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"识别异常: {ex.Message}";
            }

            result.ProcessTime = (DateTime.Now - startTime).TotalMilliseconds;
            return result;
        }

        /// <summary>
        /// 通用物体识别
        /// </summary>
        public async Task<RecognitionResult> RecognizeGeneralAsync(Image image)
        {
            var result = new RecognitionResult();
            var startTime = DateTime.Now;

            try
            {
                var token = await GetAccessTokenAsync();
                var base64Image = ImageToBase64(image);

                var url = $"https://aip.baidubce.com/rest/2.0/image-classify/v2/advanced_general?access_token={token}";
                
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("image", base64Image)
                });

                var response = await _httpClient.PostAsync(url, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var serializer = new JavaScriptSerializer();
                    var jsonResult = serializer.DeserializeObject(responseContent) as Dictionary<string, object>;
                    
                    if (jsonResult.ContainsKey("result"))
                    {
                        var results = jsonResult["result"] as object[];
                        foreach (var item in results)
                        {
                            var itemDict = item as Dictionary<string, object>;
                            result.Results.Add(new RecognitionItem
                            {
                                Name = itemDict["keyword"]?.ToString(),
                                Confidence = Convert.ToDouble(itemDict["score"] ?? 0),
                                Description = $"物体: {itemDict["keyword"]}"
                            });
                        }
                        result.Success = true;
                        result.Message = "识别成功";
                    }
                    else
                    {
                        result.Success = false;
                        result.Message = jsonResult.ContainsKey("error_msg") ? jsonResult["error_msg"]?.ToString() : "识别失败";
                    }
                }
                else
                {
                    result.Success = false;
                    result.Message = $"请求失败: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"识别异常: {ex.Message}";
            }

            result.ProcessTime = (DateTime.Now - startTime).TotalMilliseconds;
            return result;
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
} 