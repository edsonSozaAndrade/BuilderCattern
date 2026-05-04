using BuilderCattern.DTO;

namespace BuilderCattern.Interface
{
    public interface ISpringfieldCitizenBuilder
    {
        ISpringfieldCitizenBuilder BuildHead();
        ISpringfieldCitizenBuilder BuildTorso();
        ISpringfieldCitizenBuilder BuildLegs();
        ISpringfieldCitizenBuilder BuildOutfit();

        SpringfieldCitizen Build();
    }
}
