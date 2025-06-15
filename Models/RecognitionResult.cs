using System.Collections.Generic;

namespace AIRecognitionTool.Models
{
    /// <summary>
    /// AI识别结果模型
    /// </summary>
    public class RecognitionResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<RecognitionItem> Results { get; set; }
        public double ProcessTime { get; set; }

        public RecognitionResult()
        {
            Results = new List<RecognitionItem>();
        }
    }

    /// <summary>
    /// 识别项目
    /// </summary>
    public class RecognitionItem
    {
        public string Name { get; set; }
        public double Confidence { get; set; }
        public string Description { get; set; }
        public Dictionary<string, object> Properties { get; set; }

        public RecognitionItem()
        {
            Properties = new Dictionary<string, object>();
        }
    }

    /// <summary>
    /// 车牌识别结果
    /// </summary>
    public class LicensePlateResult
    {
        public string PlateNumber { get; set; }
        public string PlateColor { get; set; }
        public string PlateType { get; set; }
        public double Confidence { get; set; }
    }

    /// <summary>
    /// 车型识别结果
    /// </summary>
    public class VehicleResult
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public double Confidence { get; set; }
    }

    /// <summary>
    /// 菜品识别结果
    /// </summary>
    public class DishResult
    {
        public string DishName { get; set; }
        public string Cuisine { get; set; }
        public double Calorie { get; set; }
        public double Confidence { get; set; }
    }
} 