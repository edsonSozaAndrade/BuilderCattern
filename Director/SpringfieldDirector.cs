using BuilderCattern.DTO;
using BuilderCattern.Interface;

namespace BuilderCattern.Director
{
    public class SpringfieldDirector
    {
        public SpringfieldCitizen BuildCitizen(ISpringfieldCitizenBuilder builder)
        {
            return builder
                .BuildHead()
                .BuildTorso()
                .BuildLegs()
                .BuildOutfit()
                .Build();
        }
    }
}
