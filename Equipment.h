#pragma once
#include <iostream>
#include <string.h>



using namespace std;


class Equipment 
{
private:
	string strEquipType;
	string strCondition;
	char chaAvailable;

	
public:
	//Constructor_Destructor
	Equipment(void);
	~Equipment(void);
	Equipment(string, string, char);

	//Mutator
	void setEquipment (string, string, char);
	string getEqType (void);
	string getEqCond (void);
	char getEqAvail (void);
};

