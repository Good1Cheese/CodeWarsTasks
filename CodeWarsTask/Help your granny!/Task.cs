using System;
using System.Collections;

namespace CodeWarsTask.Help_your_granny_
{
    public class Task
    {
        public static int tour(string[] arrFriends, string[][] ftwns, Hashtable h)
        {
            double distance = 0;

            int length = arrFriends.Length;
            if (arrFriends.Length > ftwns.Length) { length--; }

            for (int i = 0; i < length; i++)
            {
                double distanceToFrined = (double)h[FindFriendTown(arrFriends[i], ftwns)];

                if (i == 0) { distance = distanceToFrined; }
                if (i + 1 == ftwns.Length || i + 1 == arrFriends.Length) { distance += distanceToFrined; continue; }

                string nextFriendTown = FindFriendTown(arrFriends[i + 1], ftwns);

                if (nextFriendTown == null) { distance += distanceToFrined; break; }

                double distanceToNextFrined = (double)h[nextFriendTown];

                distance += GetHypotenuse(distanceToNextFrined, distanceToNextFrined);
            }
            return (int)distance;
        }

        private static double GetHypotenuse(double cat1, double cat2)
        {
            double hypotenuse = cat1 * cat1 - cat2 * cat2;
            return Math.Sqrt(hypotenuse);
        }

        private const int m_friendIndex = 0;
        private const int m_friendTownIndex = 1;

        private static string FindFriendTown(string friendToFind, string[][] ftwns)
        {
            for (int i = 0; i < ftwns.Length; i++)
            {
                if (ftwns[i][m_friendIndex].Equals(friendToFind))
                {
                    return ftwns[i][m_friendTownIndex];
                }
            }

            return null;
        }
    }
}