using DesafioAMcom.Domain;

namespace DesafioAMcom.Application.Interfaces
{
    public interface ITemperatureService
    {
        double Converter(Temperature temp);
    }
}
