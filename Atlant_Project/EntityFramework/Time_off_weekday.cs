//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Atlant_Project.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Time_off_weekday
    {
        public int timeweekday_id { get; set; }
        public int Weekday_id { get; set; }
        public int Time_id { get; set; }
    
        public virtual Time Time { get; set; }
        public virtual Weekday Weekday { get; set; }
    }
}
