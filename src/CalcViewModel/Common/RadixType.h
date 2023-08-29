#pragma once

namespace CalculatorApp::ViewModel
{
    namespace Common
    {
        // This is expected to be in same order as IDM_HEX, IDM_DEC, IDM_OCT, IDM_BIN
        public enum class RadixType
        {
            Hex,
            Decimal,
            Octal,
            Binary
        };
    }
}
