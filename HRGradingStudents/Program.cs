using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HRGradingStudents {
    class Program {
        static void Main(string[] args) {

            List<int> grades = new List<int>();
            var i1 = 0;
            var i2 = 39;
            var i3 = 38;
            var i4 = 37;
            grades.Add(i1);
            grades.Add(i2);
            grades.Add(i3);
            grades.Add(i4);

            List<int> rounded = new List<int>();
            
            foreach(var i in grades) {
                if (i % 5 > 2 && i >= 38) {
                    rounded.Add(i + 5 - i % 5);
                } else {
                    rounded.Add(i);
                }
            }
            foreach(var r in rounded) {
                Console.WriteLine(r);           
            }
        }
    }
}
