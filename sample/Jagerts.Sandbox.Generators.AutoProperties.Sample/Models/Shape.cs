using Jagerts.Sandbox.Generators.AutoProperties.Sample.Attributes;

namespace Jagerts.Sandbox.Generators.AutoProperties.Sample.Models;

public partial class Shape
{
    [AutoProperty]
    private decimal _length;

    [AutoProperty]
    private decimal _width;
}
