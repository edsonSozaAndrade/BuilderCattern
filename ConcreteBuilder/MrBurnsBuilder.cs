using BuilderCattern.DTO;
using BuilderCattern.Interface;

namespace BuilderCattern.ConcreteBuilder
{
    public class MrBurnsBuilder : ISpringfieldCitizenBuilder
    {
        private readonly SpringfieldCitizen _citizen;

        public ISpringfieldCitizenBuilder BuildHead()
        {
            _citizen.Head = "Wrinkled head, evil smile";
            return this;
        }

        public ISpringfieldCitizenBuilder BuildTorso()
        {
            _citizen.Torso = "Extremely thin torso";
            return this;
        }

        public ISpringfieldCitizenBuilder BuildLegs()
        {
            _citizen.Legs = "Fragile legs, supported by wealth";
            return this;
        }

        public ISpringfieldCitizenBuilder BuildOutfit()
        {
            _citizen.Outfit = "Green suit, evil vibes";
            return this;
        }

        public SpringfieldCitizen Build()
        {
            return _citizen;
        }
    }
}
