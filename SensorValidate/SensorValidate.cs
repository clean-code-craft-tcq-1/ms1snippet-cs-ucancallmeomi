using System;
using System.Collections.Generic;

namespace SensorValidate
{
    public class SensorValidator
    {
        public static bool IsJumpValueNormal(double value, double nextValue, double maxDelta) {

            double jumpValue = CheckValueJump(value, nextValue);
            
            if(jumpValue > maxDelta) {
                return false;
            }
            return true;
        }

        public static bool validateReadings(List<Double> values, double maxDelta) {

            if (!IfFactorListEmpty(values))
            {
                if (CheckFactorReadings(values, maxDelta))
                {
                    return false;
                }
            }
            return true;
        }

        public static double CheckValueJump(double value, double nextValue)
        {
            return nextValue - value;
        }

        public static bool CheckFactorReadings(List<Double> readings, double maxDelta)
        {
            for (int i = 0; i < readings.Count - 1; i++)
            {
                if (!IsJumpValueNormal(readings[i], readings[i + 1], maxDelta))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IfFactorListEmpty(List<double> factorReadings)
        {
            if(factorReadings.Count>0)
            {
                return false;
            }

            return true;
        }

    }
}
