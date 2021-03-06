﻿using System.IO;
using System.Threading.Tasks;

namespace FileSharing.Core.Protokoli.Sherbimet.Abstrakt
{
    /// <summary>
    /// Mundeson komunikimin e dyanshem ne stream
    /// </summary>
    public interface IStreamShkruajtes
    {
        Task ShkruajMesazhAsync(Stream pranuesi, Mesazh mesazhi);

        Task ShkruajMesazhMeGjatesiAsync(Stream pranuesi, Mesazh mesazhi, int gjatesia);

        Task<Mesazh> LexoMesazhAsync(Stream derguesi);
    }
}
