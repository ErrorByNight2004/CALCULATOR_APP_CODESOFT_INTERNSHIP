#pragma once

#include "CalcManager/CalculatorResource.h"

namespace CalculatorApp::ViewModel::Common
{
    class EngineResourceProvider : public CalculationManager::IResourceProvider
    {
    public:
        EngineResourceProvider();
        virtual std::wstring GetCEngineString(std::wstring_view id) override;

    private:
        Windows::ApplicationModel::Resources::ResourceLoader ^ m_resLoader;
    };
}
