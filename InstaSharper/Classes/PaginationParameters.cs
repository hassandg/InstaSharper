﻿namespace InstaSharper.Classes
{
    public class PaginationParameters
    {
        public string NextId { get; set; } = string.Empty;
        public int MaximumPagesToLoad { get; set; }

        public static PaginationParameters MaxPagesToLoad(int maxPagesToLoad)
        {
            return new PaginationParameters {MaximumPagesToLoad = maxPagesToLoad};
        }

        public PaginationParameters StartFromId(string nextId)
        {
            NextId = nextId;
            return this;
        }
    }
}