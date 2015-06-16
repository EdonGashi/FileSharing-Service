﻿namespace FileSharing.Core.Protokoli
{
    public static class Konfigurimi
    {
        public const int PrefixGjatesia = sizeof(int);

        public const int TiketGjatesia = sizeof(int);

        public const int PaketMadhesia = 64 * 1024; // 64KB paketa

        public const string HashAlgoritmi = "MD5";

        public const int HashGjatesia = 16;

        public const int KeepAliveInterval = 1000;
    }
}