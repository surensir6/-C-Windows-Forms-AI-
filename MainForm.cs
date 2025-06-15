using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AIRecognitionTool.Services;
using AIRecognitionTool.Models;

namespace AIRecognitionTool
{
    public partial class MainForm : Form
    {
        private readonly BaiduAIService _aiService;
        private readonly OpenFileDialog _openFileDialog;

        public MainForm()
        {
            InitializeComponent();
            _aiService = new BaiduAIService();
            _openFileDialog = new OpenFileDialog
            {
                Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "选择要识别的图片"
            };
            
            InitializeContent();
        }

        /// <summary>
        /// 初始化界面内容
        /// </summary>
        private void InitializeContent()
        {
            // 软件介绍内容
            richTextBox1.Text = @"🤖 AI图像识别工具

欢迎使用AI图像识别工具！本软件基于百度AI开放平台，提供多种智能图像识别功能。

📋 主要功能：
• 车型识别 - 识别汽车品牌、车型等信息
• 车牌识别 - 识别车牌号码、颜色、类型
• 菜品识别 - 识别菜品名称、热量等信息
• 通用物体识别 - 识别图片中的各种物体

🔧 技术特性：
• 基于深度学习的图像识别技术
• 高精度识别算法
• 实时处理能力
• 友好的用户界面

💡 使用说明：
1. 选择对应的功能选项卡
2. 点击""选择图片""按钮上传图片
3. 点击""开始识别""按钮进行AI识别
4. 查看右侧识别结果

⚠️ 注意事项：
• 请确保网络连接正常
• 支持JPG、PNG、BMP等常见图片格式
• 建议上传清晰、大小适中的图片以获得更好的识别效果

📞 技术支持：
如有问题请联系开发团队
版本：v1.0
";

            // 接口说明内容
            richTextBox2.Text = @"🔗 API接口说明

本软件使用百度AI开放平台提供的图像识别服务。

📊 接口详情：

1️⃣ 车型识别 API
• 接口地址：https://aip.baidubce.com/rest/2.0/image-classify/v1/car
• 功能：识别图片中汽车的品牌、车型、年款等信息
• 返回结果：车型名称、置信度等

2️⃣ 车牌识别 API  
• 接口地址：https://aip.baidubce.com/rest/2.0/ocr/v1/license_plate
• 功能：识别车牌号码、颜色、类型等信息
• 返回结果：车牌号、颜色、置信度等

3️⃣ 菜品识别 API
• 接口地址：https://aip.baidubce.com/rest/2.0/image-classify/v2/dish
• 功能：识别菜品名称、卡路里等营养信息
• 返回结果：菜品名称、热量、置信度等

4️⃣ 通用物体识别 API
• 接口地址：https://aip.baidubce.com/rest/2.0/image-classify/v2/advanced_general
• 功能：识别图片中的各种常见物体
• 返回结果：物体名称、置信度等

🔑 认证方式：
• 使用Access Token进行API调用认证
• Token通过API Key和Secret Key获取
• Token有效期为30天

📝 调用流程：
1. 获取Access Token
2. 将图片转换为Base64编码
3. 构造HTTP POST请求
4. 发送请求到百度AI接口
5. 解析JSON响应结果
6. 展示识别结果

⚡ 性能指标：
• 识别准确率：>90%
• 平均响应时间：<2秒
• 支持的图片格式：JPG、PNG、BMP
• 最大图片大小：4MB

💰 使用限制：
• 免费版每月有调用次数限制
• 建议升级到付费版本获得更好的服务
";
        }

        // 车型识别相关事件
        private void btnVehicleSelect_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var image = Image.FromFile(_openFileDialog.FileName);
                    pictureBox1.Image = image;
                    txtVehicleResult.Text = "图片已加载，点击\"开始识别\"进行车型识别";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"加载图片失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnVehicleRecognize_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("请先选择要识别的图片", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await PerformRecognition(pictureBox1.Image, txtVehicleResult, "车型", async (img) => await _aiService.RecognizeVehicleAsync(img));
        }

        // 车牌识别相关事件
        private void btnPlateSelect_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var image = Image.FromFile(_openFileDialog.FileName);
                    pictureBox2.Image = image;
                    txtPlateResult.Text = "图片已加载，点击\"开始识别\"进行车牌识别";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"加载图片失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnPlateRecognize_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("请先选择要识别的图片", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await PerformRecognition(pictureBox2.Image, txtPlateResult, "车牌", async (img) => await _aiService.RecognizeLicensePlateAsync(img));
        }

        // 菜品识别相关事件
        private void btnDishSelect_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var image = Image.FromFile(_openFileDialog.FileName);
                    pictureBox3.Image = image;
                    txtDishResult.Text = "图片已加载，点击\"开始识别\"进行菜品识别";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"加载图片失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnDishRecognize_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image == null)
            {
                MessageBox.Show("请先选择要识别的图片", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await PerformRecognition(pictureBox3.Image, txtDishResult, "菜品", async (img) => await _aiService.RecognizeDishAsync(img));
        }

        // 通用识别相关事件
        private void btnGeneralSelect_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var image = Image.FromFile(_openFileDialog.FileName);
                    pictureBox4.Image = image;
                    txtGeneralResult.Text = "图片已加载，点击\"开始识别\"进行通用物体识别";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"加载图片失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnGeneralRecognize_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image == null)
            {
                MessageBox.Show("请先选择要识别的图片", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await PerformRecognition(pictureBox4.Image, txtGeneralResult, "通用物体", async (img) => await _aiService.RecognizeGeneralAsync(img));
        }

        /// <summary>
        /// 执行识别操作的通用方法
        /// </summary>
        private async Task PerformRecognition(Image image, TextBox resultTextBox, string recognitionType, Func<Image, Task<RecognitionResult>> recognizeFunc)
        {
            // 显示进度
            toolStripStatusLabel1.Text = $"正在进行{recognitionType}识别...";
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;

            // 禁用按钮防止重复点击
            SetButtonsEnabled(false);

            try
            {
                var result = await recognizeFunc(image);
                DisplayResult(result, resultTextBox, recognitionType);
            }
            catch (Exception ex)
            {
                resultTextBox.Text = $"识别失败：{ex.Message}\r\n\r\n请检查：\r\n1. 网络连接是否正常\r\n2. API密钥是否正确配置\r\n3. 图片格式是否支持";
                MessageBox.Show($"识别失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 恢复界面状态
                toolStripStatusLabel1.Text = "准备就绪";
                toolStripProgressBar1.Visible = false;
                SetButtonsEnabled(true);
            }
        }

        /// <summary>
        /// 显示识别结果
        /// </summary>
        private void DisplayResult(RecognitionResult result, TextBox textBox, string type)
        {
            if (result.Success && result.Results.Count > 0)
            {
                var resultText = $"🎉 {type}识别成功！\r\n";
                resultText += $"⏱️ 处理时间：{result.ProcessTime:F0}ms\r\n";
                resultText += $"📊 识别结果：\r\n\r\n";

                for (int i = 0; i < result.Results.Count; i++)
                {
                    var item = result.Results[i];
                    resultText += $"#{i + 1} {item.Description}\r\n";
                    resultText += $"   置信度：{item.Confidence:P2}\r\n\r\n";
                }

                textBox.Text = resultText;
            }
            else
            {
                textBox.Text = $"❌ {type}识别失败\r\n错误信息：{result.Message}\r\n\r\n可能的原因：\r\n1. 图片中没有识别到相关内容\r\n2. 图片质量不够清晰\r\n3. API调用异常";
            }
        }

        /// <summary>
        /// 设置按钮启用状态
        /// </summary>
        private void SetButtonsEnabled(bool enabled)
        {
            btnVehicleSelect.Enabled = enabled;
            btnVehicleRecognize.Enabled = enabled;
            btnPlateSelect.Enabled = enabled;
            btnPlateRecognize.Enabled = enabled;
            btnDishSelect.Enabled = enabled;
            btnDishRecognize.Enabled = enabled;
            btnGeneralSelect.Enabled = enabled;
            btnGeneralRecognize.Enabled = enabled;
        }

        /// <summary>
        /// 窗体关闭时释放资源
        /// </summary>
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _aiService?.Dispose();
            _openFileDialog?.Dispose();
            base.OnFormClosed(e);
        }
    }
} 