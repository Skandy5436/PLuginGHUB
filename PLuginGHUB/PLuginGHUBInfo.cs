using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace PLuginGHUB
{
  public class PLuginGHUBInfo : GH_AssemblyInfo
  {
    public override string Name => "PLuginGHUB";

    //Return a 24x24 pixel bitmap to represent this GHA library.
    public override Bitmap Icon => null;

    //Return a short string describing the purpose of this GHA library.
    public override string Description => "";

    public override Guid Id => new Guid("6bd1e01c-58ca-4e4a-b2c1-4a93b10373f5");

    //Return a string identifying you or your company.
    public override string AuthorName => "";

    //Return a string representing your preferred contact details.
    public override string AuthorContact => "";
  }
}