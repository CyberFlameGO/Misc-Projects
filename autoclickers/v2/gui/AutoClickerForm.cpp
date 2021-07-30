#include "AutoClickerForm.h"

using namespace System;
using namespace System::Windows::Forms;
[STAThread]

int main(array<String^>^ args)
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	AutoClickerGUI::AutoClickerForm FORM;
	Application::Run(% FORM);
}