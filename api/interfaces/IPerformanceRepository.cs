using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Abscence;
using api.Dtos.Heuresupplimentaire;
using api.Model;

namespace api.interfaces
{
    public interface IPerformanceRepository
    {
        Task<Heuresupplimentaires> AddHeuressupplimentaires(CreateHeuresupplimentaire createHeuresupplimentaire);
        Task<Abscence> AddAbscence(CreateAbscenceDto createAbscenceDto);
        Task<Abscence> JustifyAbscence(int AbscenceId);

    }
}