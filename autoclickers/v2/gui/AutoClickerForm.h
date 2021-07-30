#pragma once

#include <stdlib.h>
#include <iostream>
#include <fstream>
#include <Windows.h>
#include <string>
#include <algorithm>
#include <msclr\marshal_cppstd.h>

#include <direct.h>
#define GetCurrentDir _getcwd

namespace AutoClickerGUI {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for AutoClickerForm
	/// </summary>
	public ref class AutoClickerForm : public System::Windows::Forms::Form
	{
	public:
		AutoClickerForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~AutoClickerForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::NumericUpDown^ CPS_SELECTOR;
	protected:
	private: System::Windows::Forms::Label^ CPS_LABEL;
	private: System::Windows::Forms::Button^ LAUNCH_BUTTON;
	private: System::Windows::Forms::ComboBox^ MB_SELECTOR;
	private: System::Windows::Forms::Label^ MB_LABEL;
	private: System::Windows::Forms::Button^ GITHUB_BUTTON;
	private: System::Windows::Forms::RadioButton^ REPEAT_X;
	private: System::Windows::Forms::RadioButton^ REPEAT_UNTIL_STOPPED;
	private: System::Windows::Forms::NumericUpDown^ REPEAT_SELECTOR;

	private: System::Windows::Forms::Label^ REPEAT_X_LABEL;




	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->CPS_SELECTOR = (gcnew System::Windows::Forms::NumericUpDown());
			this->CPS_LABEL = (gcnew System::Windows::Forms::Label());
			this->LAUNCH_BUTTON = (gcnew System::Windows::Forms::Button());
			this->MB_SELECTOR = (gcnew System::Windows::Forms::ComboBox());
			this->MB_LABEL = (gcnew System::Windows::Forms::Label());
			this->GITHUB_BUTTON = (gcnew System::Windows::Forms::Button());
			this->REPEAT_X = (gcnew System::Windows::Forms::RadioButton());
			this->REPEAT_UNTIL_STOPPED = (gcnew System::Windows::Forms::RadioButton());
			this->REPEAT_SELECTOR = (gcnew System::Windows::Forms::NumericUpDown());
			this->REPEAT_X_LABEL = (gcnew System::Windows::Forms::Label());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->CPS_SELECTOR))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->REPEAT_SELECTOR))->BeginInit();
			this->SuspendLayout();
			// 
			// CPS_SELECTOR
			// 
			this->CPS_SELECTOR->Location = System::Drawing::Point(12, 12);
			this->CPS_SELECTOR->Minimum = System::Decimal(gcnew cli::array< System::Int32 >(4) { 1, 0, 0, 0 });
			this->CPS_SELECTOR->Name = L"CPS_SELECTOR";
			this->CPS_SELECTOR->Size = System::Drawing::Size(143, 20);
			this->CPS_SELECTOR->TabIndex = 0;
			this->CPS_SELECTOR->Value = System::Decimal(gcnew cli::array< System::Int32 >(4) { 1, 0, 0, 0 });
			this->CPS_SELECTOR->ValueChanged += gcnew System::EventHandler(this, &AutoClickerForm::CPS_SELECTOR_ValueChanged);
			// 
			// CPS_LABEL
			// 
			this->CPS_LABEL->AutoSize = true;
			this->CPS_LABEL->Location = System::Drawing::Point(161, 15);
			this->CPS_LABEL->Name = L"CPS_LABEL";
			this->CPS_LABEL->Size = System::Drawing::Size(28, 13);
			this->CPS_LABEL->TabIndex = 1;
			this->CPS_LABEL->Text = L"CPS";
			// 
			// LAUNCH_BUTTON
			// 
			this->LAUNCH_BUTTON->Location = System::Drawing::Point(12, 119);
			this->LAUNCH_BUTTON->Name = L"LAUNCH_BUTTON";
			this->LAUNCH_BUTTON->Size = System::Drawing::Size(177, 51);
			this->LAUNCH_BUTTON->TabIndex = 2;
			this->LAUNCH_BUTTON->Text = L"Launch";
			this->LAUNCH_BUTTON->UseVisualStyleBackColor = true;
			this->LAUNCH_BUTTON->Click += gcnew System::EventHandler(this, &AutoClickerForm::LAUNCH_BUTTON_Click);
			// 
			// MB_SELECTOR
			// 
			this->MB_SELECTOR->DisplayMember = L"Left";
			this->MB_SELECTOR->DropDownStyle = System::Windows::Forms::ComboBoxStyle::DropDownList;
			this->MB_SELECTOR->FormattingEnabled = true;
			this->MB_SELECTOR->Items->AddRange(gcnew cli::array< System::Object^  >(2) { L"Left", L"Right" });
			this->MB_SELECTOR->Location = System::Drawing::Point(196, 14);
			this->MB_SELECTOR->Name = L"MB_SELECTOR";
			this->MB_SELECTOR->Size = System::Drawing::Size(100, 21);
			this->MB_SELECTOR->TabIndex = 4;
			this->MB_SELECTOR->SelectedIndexChanged += gcnew System::EventHandler(this, &AutoClickerForm::MB_SELECTOR_SelectedIndexChanged);
			this->MB_SELECTOR->SelectedItem = L"Left";
			// 
			// MB_LABEL
			// 
			this->MB_LABEL->AutoSize = true;
			this->MB_LABEL->Location = System::Drawing::Point(298, 17);
			this->MB_LABEL->Name = L"MB_LABEL";
			this->MB_LABEL->Size = System::Drawing::Size(73, 13);
			this->MB_LABEL->TabIndex = 5;
			this->MB_LABEL->Text = L"Mouse Button";
			// 
			// GITHUB_BUTTON
			// 
			this->GITHUB_BUTTON->Location = System::Drawing::Point(195, 119);
			this->GITHUB_BUTTON->Name = L"GITHUB_BUTTON";
			this->GITHUB_BUTTON->Size = System::Drawing::Size(175, 51);
			this->GITHUB_BUTTON->TabIndex = 6;
			this->GITHUB_BUTTON->Text = L"Github Page";
			this->GITHUB_BUTTON->UseVisualStyleBackColor = true;
			this->GITHUB_BUTTON->Click += gcnew System::EventHandler(this, &AutoClickerForm::GITHUB_BUTTON_Click);
			// 
			// REPEAT_X
			// 
			this->REPEAT_X->AutoSize = true;
			this->REPEAT_X->Location = System::Drawing::Point(12, 51);
			this->REPEAT_X->Name = L"REPEAT_X";
			this->REPEAT_X->Size = System::Drawing::Size(60, 17);
			this->REPEAT_X->TabIndex = 7;
			this->REPEAT_X->TabStop = true;
			this->REPEAT_X->Text = L"Repeat";
			this->REPEAT_X->UseVisualStyleBackColor = true;
			this->REPEAT_X->CheckedChanged += gcnew System::EventHandler(this, &AutoClickerForm::REPEAT_X_CheckedChanged);
			// 
			// REPEAT_UNTIL_STOPPED
			// 
			this->REPEAT_UNTIL_STOPPED->AutoSize = true;
			this->REPEAT_UNTIL_STOPPED->Checked = true;
			this->REPEAT_UNTIL_STOPPED->Location = System::Drawing::Point(12, 77);
			this->REPEAT_UNTIL_STOPPED->Name = L"REPEAT_UNTIL_STOPPED";
			this->REPEAT_UNTIL_STOPPED->Size = System::Drawing::Size(123, 17);
			this->REPEAT_UNTIL_STOPPED->TabIndex = 8;
			this->REPEAT_UNTIL_STOPPED->TabStop = true;
			this->REPEAT_UNTIL_STOPPED->Text = L"Repeat until stopped";
			this->REPEAT_UNTIL_STOPPED->UseVisualStyleBackColor = true;
			this->REPEAT_UNTIL_STOPPED->CheckedChanged += gcnew System::EventHandler(this, &AutoClickerForm::REPEAT_UNTIL_STOPPED_CheckedChanged);
			// 
			// REPEAT_SELECTOR
			// 
			this->REPEAT_SELECTOR->Location = System::Drawing::Point(78, 51);
			this->REPEAT_SELECTOR->Maximum = System::Decimal(gcnew cli::array< System::Int32 >(4) { 10000, 0, 0, 0 });
			this->REPEAT_SELECTOR->Minimum = System::Decimal(gcnew cli::array< System::Int32 >(4) { 1, 0, 0, 0 });
			this->REPEAT_SELECTOR->Name = L"REPEAT_SELECTOR";
			this->REPEAT_SELECTOR->Size = System::Drawing::Size(45, 20);
			this->REPEAT_SELECTOR->TabIndex = 9;
			this->REPEAT_SELECTOR->Value = System::Decimal(gcnew cli::array< System::Int32 >(4) { 1, 0, 0, 0 });
			this->REPEAT_SELECTOR->ValueChanged += gcnew System::EventHandler(this, &AutoClickerForm::REPEAT_SELECTOR_ValueChanged);
			// 
			// REPEAT_X_LABEL
			// 
			this->REPEAT_X_LABEL->AutoSize = true;
			this->REPEAT_X_LABEL->Location = System::Drawing::Point(129, 55);
			this->REPEAT_X_LABEL->Name = L"REPEAT_X_LABEL";
			this->REPEAT_X_LABEL->Size = System::Drawing::Size(31, 13);
			this->REPEAT_X_LABEL->TabIndex = 10;
			this->REPEAT_X_LABEL->Text = L"times";
			// 
			// AutoClickerForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(382, 181);
			this->Controls->Add(this->REPEAT_X_LABEL);
			this->Controls->Add(this->REPEAT_SELECTOR);
			this->Controls->Add(this->REPEAT_UNTIL_STOPPED);
			this->Controls->Add(this->REPEAT_X);
			this->Controls->Add(this->GITHUB_BUTTON);
			this->Controls->Add(this->MB_LABEL);
			this->Controls->Add(this->MB_SELECTOR);
			this->Controls->Add(this->LAUNCH_BUTTON);
			this->Controls->Add(this->CPS_LABEL);
			this->Controls->Add(this->CPS_SELECTOR);
			this->Name = L"AutoClickerForm";
			this->Text = L"Edit Your Settings";
			this->Load += gcnew System::EventHandler(this, &AutoClickerForm::AutoClickerForm_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->CPS_SELECTOR))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->REPEAT_SELECTOR))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}

#pragma endregion
		private: System::Void AutoClickerForm_Load(System::Object^ sender, System::EventArgs^ e) {
			char BUFFER[FILENAME_MAX];
			GetCurrentDir(BUFFER, FILENAME_MAX);
			std::string DIR(BUFFER);
			std::string PATH = DIR + "\\console\\data.txt";

			std::ofstream WRITE;
			WRITE.open(PATH);

			if (WRITE.is_open())
			{
				WRITE << "CPS=1\n";
				WRITE << "MOUSE_BUTTON=LEFT\n";
				WRITE << "REPEAT=0";
			}

			WRITE.close();
		}

		private: System::Void LAUNCH_BUTTON_Click(System::Object^ sender, System::EventArgs^ e) {
			char BUFFER[FILENAME_MAX];
			GetCurrentDir(BUFFER, FILENAME_MAX);
			std::string DIR(BUFFER);
			std::string PATH = DIR + "\\console\\AutoClickerConsole.exe";

			system((PATH).c_str());
		}

		private: System::Void CPS_SELECTOR_ValueChanged(System::Object^ sender, System::EventArgs^ e) {
			char BUFFER[FILENAME_MAX];
			GetCurrentDir(BUFFER, FILENAME_MAX);
			std::string DIR(BUFFER);
			std::string PATH = DIR + "\\console\\data.txt";

			std::ifstream READ;
			READ.open(PATH);

			std::string LINE;
			std::string FILE_CONTENT[3];

			if (READ.is_open())
			{
				int loop = -1;
				while (std::getline(READ, LINE))
				{
					loop++;
					FILE_CONTENT[loop] = LINE;
				}
			}

			READ.close();

			FILE_CONTENT[0] = std::to_string((int)this->CPS_SELECTOR->Value);

			std::ofstream WRITE;
			WRITE.open(PATH);

			if (WRITE.is_open())
			{
				WRITE << "CPS=" << FILE_CONTENT[0] << "\n";
				WRITE << FILE_CONTENT[1] << "\n";
				WRITE << FILE_CONTENT[2];
			}

			WRITE.close();
		}

		private: System::Void MB_SELECTOR_SelectedIndexChanged(System::Object^ sender, System::EventArgs^ e) {
			char BUFFER[FILENAME_MAX];
			GetCurrentDir(BUFFER, FILENAME_MAX);
			std::string DIR(BUFFER);
			std::string PATH = DIR + "\\console\\data.txt";

			std::ifstream READ;
			READ.open(PATH);

			std::string LINE;
			std::string FILE_CONTENT[3];

			if (READ.is_open())
			{
				int loop = -1;
				while (std::getline(READ, LINE))
				{
					loop++;
					FILE_CONTENT[loop] = LINE;
				}
			}

			READ.close();

			std::string BUTTON = msclr::interop::marshal_as<std::string>(this->MB_SELECTOR->Text);
			std::transform(BUTTON.begin(), BUTTON.end(), BUTTON.begin(), ::toupper);

			FILE_CONTENT[1] = BUTTON;

			std::ofstream WRITE;
			WRITE.open(PATH);

			if (WRITE.is_open())
			{
				WRITE << FILE_CONTENT[0] << "\n";
				WRITE << "MOUSE_BUTTON=" << FILE_CONTENT[1] << "\n";
				WRITE << FILE_CONTENT[2];
			}

			WRITE.close();
		}

		private: System::Void GITHUB_BUTTON_Click(System::Object^ sender, System::EventArgs^ e) {
			system("start https://github.com/Yochran/AutoClicker-v2");
		}

		private: System::Void REPEAT_UNTIL_STOPPED_CheckedChanged(System::Object^ sender, System::EventArgs^ e) {
			if (this->REPEAT_UNTIL_STOPPED->Checked)
			{
				char BUFFER[FILENAME_MAX];
				GetCurrentDir(BUFFER, FILENAME_MAX);
				std::string DIR(BUFFER);
				std::string PATH = DIR + "\\console\\data.txt";

				std::ifstream READ;
				READ.open(PATH);

				std::string LINE;
				std::string FILE_CONTENT[3];

				if (READ.is_open())
				{
					int loop = -1;
					while (std::getline(READ, LINE))
					{
						loop++;
						FILE_CONTENT[loop] = LINE;
					}
				}

				READ.close();

				std::ofstream WRITE;
				WRITE.open(PATH);

				if (WRITE.is_open())
				{
					WRITE << FILE_CONTENT[0] << "\n";
					WRITE << FILE_CONTENT[1] << "\n";
					WRITE << "REPEAT=0";
				}

				WRITE.close();
			}
		}

		private: System::Void REPEAT_X_CheckedChanged(System::Object^ sender, System::EventArgs^ e) {
			if (this->REPEAT_X->Checked)
			{
				char BUFFER[FILENAME_MAX];
				GetCurrentDir(BUFFER, FILENAME_MAX);
				std::string DIR(BUFFER);
				std::string PATH = DIR + "\\console\\data.txt";

				std::ifstream READ;
				READ.open(PATH);

				std::string LINE;
				std::string FILE_CONTENT[3];

				if (READ.is_open())
				{
					int loop = -1;
					while (std::getline(READ, LINE))
					{
						loop++;
						FILE_CONTENT[loop] = LINE;
					}
				}

				READ.close();

				std::string REPEAT_AMOUNT = std::to_string((int) this->REPEAT_SELECTOR->Value);
				FILE_CONTENT[2] = REPEAT_AMOUNT;

				std::ofstream WRITE;
				WRITE.open(PATH);

				if (WRITE.is_open())
				{
					WRITE << FILE_CONTENT[0] << "\n";
					WRITE << FILE_CONTENT[1] << "\n";
					WRITE << "REPEAT=" << FILE_CONTENT[2];
				}

				WRITE.close();
			}
		}

		private: System::Void REPEAT_SELECTOR_ValueChanged(System::Object^ sender, System::EventArgs^ e) {
			if (this->REPEAT_X->Checked)
			{
				char BUFFER[FILENAME_MAX];
				GetCurrentDir(BUFFER, FILENAME_MAX);
				std::string DIR(BUFFER);
				std::string PATH = DIR + "\\console\\data.txt";

				std::ifstream READ;
				READ.open(PATH);

				std::string LINE;
				std::string FILE_CONTENT[3];

				if (READ.is_open())
				{
					int loop = -1;
					while (std::getline(READ, LINE))
					{
						loop++;
						FILE_CONTENT[loop] = LINE;
					}
				}

				READ.close();

				std::string REPEAT_AMOUNT = std::to_string((int)this->REPEAT_SELECTOR->Value);
				FILE_CONTENT[2] = REPEAT_AMOUNT;

				std::ofstream WRITE;
				WRITE.open(PATH);

				if (WRITE.is_open())
				{
					WRITE << FILE_CONTENT[0] << "\n";
					WRITE << FILE_CONTENT[1] << "\n";
					WRITE << "REPEAT=" << FILE_CONTENT[2];
				}

				WRITE.close();
			}
		}
	};
}
