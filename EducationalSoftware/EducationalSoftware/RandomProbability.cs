using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalSoftware
{
    public class RandomProbability
    {
        /// <summary>
        /// Random choice given some probabilities.
        /// </summary>
        /// <param name="probabilities"></param>
        /// <returns></returns>
        public static string Choose(float[] floatprobabilities,string[] stringprobabilities)
        {
            List<(string, float)> probabilities = new List<(string, float)>();
            for(int i=0; i < floatprobabilities.Length; i++)
            {
                probabilities.Add((stringprobabilities[i], floatprobabilities[i]));
            }
            probabilities.Sort((p, q) => p.Item2.CompareTo(q.Item2));
            int prob = new Random().Next(0, 101);
            int item = 0;
            double counter = -1;
            for(int i = 0; i < probabilities.Count; i++)
            {
                counter += probabilities[item].Item2;
                if (prob < counter)
                {
                    return probabilities[i].Item1;
                }
            }
            return probabilities.Last().Item1;


        }
    }

}
