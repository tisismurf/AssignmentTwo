using JCMURPHYShapes;
using System.Linq.Expressions;

namespace AssingmentTwo {

  internal class Program {







    static void Main(string[] args) {

      var array = 0;

      var column1 = new List<string>();

      string[] inputShape = { };

      string[] inputShapeTwo = { };
      string[] nullString = { };

      var total = new double[3];
      var inputs = new double[3];


      Shape.Cuboid Cuboid = new Shape.Cuboid(inputs[0], inputs[1], inputs[2]);
      Shape.Cylinder Cylinder = new Shape.Cylinder(inputs[0], inputs[1]);
      Shape.Cube Cube = new Shape.Cube(inputs[0]);
      Shape.Sphere Sphere = new Shape.Sphere(inputs[0], inputs[2]);

      Console.WriteLine("Enter the csv file path.");
      var filePath = Console.ReadLine();
      
      try {

        using (var rd = new StreamReader(filePath)) {

          while (true) {


            if (inputShape != null!) {

              try {

                var splits = rd.ReadLine().Split(';');
                column1.Add(splits[0]);
                }
              catch {
                Console.WriteLine("Total Value " + total[0]);
                Console.WriteLine("End of File");
                Console.ReadLine();

                }
              finally { }
              

              inputShape = column1.ToArray();

              inputShapeTwo = inputShape[array].ToString().Split(',');

              // Cuboid Volume //
              if (inputShapeTwo[0].ToLower() == "cuboid" & inputShapeTwo[1].ToLower() == "volume") {

                Cuboid.Height = double.Parse(inputShapeTwo[2]);
                Cuboid.Length = double.Parse(inputShapeTwo[3]);
                Cuboid.Width = double.Parse(inputShapeTwo[4]);

                var volume = Cuboid.GetVolume();
                Console.WriteLine(inputShapeTwo[0] + " #" + array + "'s volume is " + volume.ToString());
                total[0] += volume;
                inputShapeTwo = nullString;
                array++;
                }

              // Cuboid Area // 
              else if (inputShapeTwo[0] == "cuboid" & inputShapeTwo[1] == "area") {

                Cuboid.Height = double.Parse(inputShapeTwo[2]);
                Cuboid.Length = double.Parse(inputShapeTwo[3]);
                Cuboid.Width = double.Parse(inputShapeTwo[4]);
                


                var area = Cuboid.GetArea();
                Console.WriteLine(inputShapeTwo[0] + " #" + array + "'s area is " + area.ToString());
                total[0] += area;
                inputShapeTwo = nullString;
                array++;
                }

              // Cylinder Volume //
              else if (inputShapeTwo[0] == "cylinder" & inputShapeTwo[1] == "volume") {

                Cylinder.Height = double.Parse(inputShapeTwo[2]);
                Cylinder.Radius = double.Parse(inputShapeTwo[3]);
                


                var volume = Cylinder.GetVolume();
                Console.WriteLine(inputShapeTwo[0] + " #" + array + "'s volume is " + volume.ToString());
                total[0] += volume;
                inputShapeTwo = nullString;
                array++;
                }

              // Cylinder Area //
              else if (inputShapeTwo[0] == "cylinder" & inputShapeTwo[1] == "area") {

                Cylinder.Height = double.Parse(inputShapeTwo[2]);
                Cylinder.Radius = double.Parse(inputShapeTwo[3]);
                


                var area = Cylinder.GetArea();
                Console.WriteLine(inputShapeTwo[0] + " #" + array + "'s area is " + area.ToString());
                total[0] += area;
                inputShapeTwo= nullString;
                array++;
                }

              // Cube Volume //
              else if (inputShapeTwo[0] == "cube" & inputShapeTwo[1] == "volume") {

                Cube.Length = double.Parse(inputShapeTwo[2]);



                var volume = Cube.GetVolume();
                Console.WriteLine(inputShapeTwo[0] + " #" + array + "'s volume is " + volume.ToString());
                total[0] += volume;
                inputShapeTwo= nullString;
                array++;
                }

              // Cube Area //
              else if (inputShapeTwo[0] == "cube" & inputShapeTwo[1] == "area") {

                Cube.Length = double.Parse(inputShapeTwo[2]);
                var area = Cube.GetArea();
                Console.WriteLine(inputShapeTwo[0] + " #" + array + "'s area is " + area.ToString());
                total[0] += area;
                inputShapeTwo= nullString;
                array++;
                }
              // Sphere Volume //
              else if (inputShapeTwo[0] == "sphere" & inputShapeTwo[1] == "volume") {

                Sphere.Radius = double.Parse(inputShapeTwo[2]);
                var volume = Sphere.GetVolume();
                
                Console.WriteLine(inputShapeTwo[0] + " #" + array + "'s volume is " + volume.ToString());
                total[0] += volume;
                inputShapeTwo= nullString;
                array++;
                }

              // Sphere Area //
              else if (inputShapeTwo[0] == "sphere" & inputShapeTwo[1] == "area") {

                Sphere.Radius = double.Parse(inputShapeTwo[2]);
                var area = Sphere.GetArea();
                
                Console.WriteLine(inputShapeTwo[0] + " #" + array + "'s area is " + area.ToString());
                total[0] += area;
                inputShapeTwo= nullString;
                array++;
                }
              }
            }
          }
        }




      catch {
        Console.WriteLine("File is open or does not exist. Please check the name and restart the application");
        Console.ReadLine();


        }
      }
    
  }
}



        
              
            
          
        
      
    
  


                
              
          
        
      
    
  







  

