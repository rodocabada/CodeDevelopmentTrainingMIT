﻿namespace PhoneBook.BL.Catalogs
{
    public class Department
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CostCenter { get; set; }
        public bool Status { get; set; }
        public int IdManager { get; set; }
    }
}