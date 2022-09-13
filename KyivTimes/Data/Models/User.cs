﻿namespace KyivTimes.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public IEnumerable<Article> Articles { get; set; }
    }
}
