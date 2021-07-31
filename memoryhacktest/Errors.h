#ifndef ERRORS_H
#define ERRORS_H

#pragma once

#include <stdlib.h>
#include <string>

class Errors
{
	public:
		static int THROW(std::string MESSAGE);
};

#endif

