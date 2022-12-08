// Shapes Library//﻿

using System;

namespace JCMURPHYShapes {


  public abstract class Shape {
    public abstract double GetArea();
    public abstract double GetVolume();
    public class Cuboid : Shape {
      public double Length { get; set; }
      public double Width { get; set; }
      public double Height { get; set; }
      public Cuboid(double length, double width, double height) {
        this.Length = length;
        this.Width = width;
        this.Height = height;
        }
      public override double GetArea() {

        return   2d * ((Height * Length) + (Height * Width) + (Length* Width));
        }
         public override double GetVolume() => Length * Width * Height;          
      }
    public class Cube : Shape {
      public double Length { get; set; }

      public Cube(double length) {
        this.Length = length;
        }
      public override double GetArea() => 6d * Math.Pow(Length, 2d);
      public override double GetVolume() => Math.Pow(Length,3d);
      }
    public class Sphere : Shape {
      public double Radius { get; set; }
      public double Height { get; set; }
      public Sphere(double radius, double height) {
        this.Radius = radius;
        this.Height = height;
        }
      public override double GetArea() => (4d * Math.PI) * (Math.Pow(Radius, 2d));
      public override double GetVolume() {
        return (4d / 3d) * Math.PI * Math.Pow(Radius,3d);
        }
      }
    public class Cylinder : Shape {
      public double Radius { get; set; }
      public double Height { get; set; }
      public Cylinder(double radius, double height) {
        this.Radius = radius;
        this.Height = height;
        }
      public override double GetArea() {
        return (2d * Math.PI * Radius * Height) + (2d * Math.PI * Math.Pow( Radius,2));
        }
      public override double GetVolume() => Math.PI * Math.Pow(Radius, 2d) * Height;
      }
    }
  }

      
          
      
    
      

    
  
  
