#pragma once

namespace CalculatorApp::ViewModel::Common
{
    public ref class AppResourceProvider sealed
    {
    public:
        static AppResourceProvider ^ GetInstance();
        Platform::String ^ GetResourceString(_In_ Platform::String ^ key);
        Platform::String ^ GetCEngineString(_In_ Platform::String ^ key);

    private:
        AppResourceProvider();
        Windows::ApplicationModel::Resources::ResourceLoader ^ m_stringResLoader;
        Windows::ApplicationModel::Resources::ResourceLoader ^ m_cEngineStringResLoader;
    };
}
