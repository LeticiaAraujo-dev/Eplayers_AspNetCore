using System.Collections.Generic;
using Eplayers_AspNetCore.Models;

namespace Eplayers_AspNetCore.Interface
{
    public interface IJogador
    {
        void Create (Jogador j);
        List<Jogador> ReadAll();
        void Update (Jogador j);
        void Delete (int id); 
    }
}