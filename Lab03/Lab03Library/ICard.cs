using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Library
{
    public interface ICard
    {
        CardFace Face { get; }
        CardSuit Suit { get; }

        void Print(int x, int y);
    }
}
