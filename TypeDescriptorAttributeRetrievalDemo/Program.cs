using System;
using System.ComponentModel;
using System.Linq;

// See http://stackoverflow.com/questions/22844435/typedescriptor-attribute-retrieval-inconsistency
namespace TypeDescriptorAttributeRetrievalDemo
{
    public struct Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Enum Enum { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Use object - see http://stackoverflow.com/a/22886844/501556
            object person = new Person();

            var typeDescriptionProvider = TypeDescriptor.AddAttributes(person, new DescriptionAttribute("Some description of this person"));

            // Returns ZERO attributes if person is a *struct* instance (that is NOT declared as object),
            // but does return the DescriptionAttribute if person is a *class* instance
            var descriptionAttributes = TypeDescriptor.GetAttributes(person).OfType<DescriptionAttribute>().ToList();

            // Always returns the DescriptionAttribute, GetTypeDescriptor's parameter can be anything
            var descriptionAttributesUsingTdp = typeDescriptionProvider.GetTypeDescriptor(person).GetAttributes().OfType<DescriptionAttribute>().ToList();

            Console.ReadLine();
        }
    }
}
