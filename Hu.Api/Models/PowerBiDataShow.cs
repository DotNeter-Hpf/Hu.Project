using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("PowerBiDataShow")]
    public class PowerBiDataShow
    {
        /// <summary>
        /// 哪个班组 
        ///</summary>
         [SugarColumn(ColumnName="shiftID"    )]
         public string ShiftID { get; set; }
        /// <summary>
        /// 设备ID 
        ///</summary>
         [SugarColumn(ColumnName="devID"    )]
         public string DevID { get; set; }
        /// <summary>
        /// 日期 
        ///</summary>
         [SugarColumn(ColumnName="time"    )]
         public string Time { get; set; }
        /// <summary>
        /// 计划停机 
        ///</summary>
         [SugarColumn(ColumnName="planStop"    )]
         public string PlanStop { get; set; }
        /// <summary>
        /// 保养 
        ///</summary>
         [SugarColumn(ColumnName="maintain"    )]
         public string Maintain { get; set; }
        /// <summary>
        /// 质量停工 
        ///</summary>
         [SugarColumn(ColumnName="Quality"    )]
         public string Quality { get; set; }
        /// <summary>
        /// 设备故障 
        ///</summary>
         [SugarColumn(ColumnName="Device"    )]
         public string Device { get; set; }
        /// <summary>
        /// 缺料 
        ///</summary>
         [SugarColumn(ColumnName="Material"    )]
         public string Material { get; set; }
        /// <summary>
        /// 人员不在岗 
        ///</summary>
         [SugarColumn(ColumnName="noPerson"    )]
         public string NoPerson { get; set; }
        /// <summary>
        /// 工具更换 
        ///</summary>
         [SugarColumn(ColumnName="changeTools"    )]
         public string ChangeTools { get; set; }
        /// <summary>
        /// 换型 
        ///</summary>
         [SugarColumn(ColumnName="changeModel"    )]
         public string ChangeModel { get; set; }
        /// <summary>
        /// 其他 
        ///</summary>
         [SugarColumn(ColumnName="other"    )]
         public string Other { get; set; }
        /// <summary>
        /// 班可用率 
        ///</summary>
         [SugarColumn(ColumnName="availabilityB"    )]
         public string AvailabilityB { get; set; }
        /// <summary>
        /// 日可用率 
        ///</summary>
         [SugarColumn(ColumnName="availabilitD"    )]
         public string AvailabilitD { get; set; }
        /// <summary>
        /// 班级效率 
        ///</summary>
         [SugarColumn(ColumnName="performanceB"    )]
         public string PerformanceB { get; set; }
        /// <summary>
        /// 日绩效率 
        ///</summary>
         [SugarColumn(ColumnName="performanceD"    )]
         public string PerformanceD { get; set; }
        /// <summary>
        /// 班质量率 
        ///</summary>
         [SugarColumn(ColumnName="qualityrateB"    )]
         public string QualityrateB { get; set; }
        /// <summary>
        /// 日质量率 
        ///</summary>
         [SugarColumn(ColumnName="qualityrateD"    )]
         public string QualityrateD { get; set; }
        /// <summary>
        /// 班OEE 
        ///</summary>
         [SugarColumn(ColumnName="shiftOEE"    )]
         public string ShiftOEE { get; set; }
        /// <summary>
        /// 日OEE 
        ///</summary>
         [SugarColumn(ColumnName="dailyOEE"    )]
         public string DailyOEE { get; set; }
    }
}
