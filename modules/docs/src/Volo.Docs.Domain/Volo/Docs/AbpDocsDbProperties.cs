﻿namespace Volo.Docs
{
    public static class AbpDocsDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Docs";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "Docs";
    }
}
