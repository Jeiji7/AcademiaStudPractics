//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcademiaStudPractics.BDSHKA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingener
    {
        public int ID_employee { get; set; }
        public string Spectial { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
