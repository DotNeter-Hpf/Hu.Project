using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("CalculationRate")]
    public class CalculationRate
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="devID"    )]
         public string DevID { get; set; }
        /// <summary>
        /// 班别 
        ///</summary>
         [SugarColumn(ColumnName="shiftID"    )]
         public int? ShiftID { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="time"    )]
         public string Time { get; set; }
        /// <summary>
        /// 班可用率 
        ///</summary>
         [SugarColumn(ColumnName="availabilityB"    )]
         public string AvailabilityB { get; set; }
        /// <summary>
        /// 日可用率 
        ///</summary>
         [SugarColumn(ColumnName="availabilityD"    )]
         public string AvailabilityD { get; set; }
        /// <summary>
        /// 班绩效率 
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
        /// 班Oee 
        ///</summary>
         [SugarColumn(ColumnName="shiftOEE"    )]
         public string ShiftOEE { get; set; }
        /// <summary>
        /// 日Oee 
        ///</summary>
         [SugarColumn(ColumnName="dailyOEE"    )]
         public string DailyOEE { get; set; }
    }
}
