using BuilderCattern.DTO;
using BuilderCattern.Interface;

namespace BuilderCattern.ConcreteBuilder
{
    public class HomerBuilder : ISpringfieldCitizenBuilder
    {
        private readonly SpringfieldCitizen _citizen;

        public ISpringfieldCitizenBuilder BuildHead()
        {
            _citizen.Head = "Bald head, big eyes, permanent confusion";
            return this;
        }

        public ISpringfieldCitizenBuilder BuildTorso()
        {
            _citizen.Torso = "Average torso, donut-powered metabolism";
            return this;
        }

        public ISpringfieldCitizenBuilder BuildLegs()
        {
            _citizen.Legs = "Short legs, low motivation";
            return this;
        }

        public ISpringfieldCitizenBuilder BuildOutfit()
        {
            _citizen.Outfit = "White shirt, blue pants";
            return this;
        }

        public SpringfieldCitizen Build()
        {
            return _citizen;
        }
    }
}
