﻿using System.Diagnostics;

namespace FluentAssertions.Numeric
{
    /// <summary>
    /// Contains a number of methods to assert that a nullable <see cref="int"/> is in the expected state.
    /// </summary>
    [DebuggerNonUserCode]
    public class NullableIntAssertions : NullableNumericAssertions<int>
    {
        public NullableIntAssertions(int? value)
            : base(value)
        {
        }

        private protected override int? CalculateDifferenceForFailureMessage(int expected) => Subject - expected;

        private protected override int GetMinimalDifferenceThresholdForFailureMessage() => -10;

        private protected override int GetMaximalDifferenceThresholdForFailureMessage() => 10;
    }
}
