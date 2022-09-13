﻿namespace KyivTimes.Data.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        
        public DateTime CreatedDate { get; set; }

    }
}
