/**********************************************************************************
***																				***
***	Robert Bertenshaw															***
***	Kandyce Davis																***
***	Danielle Henry																***
***	Matthew Smith																***
***																				***
***	Group C	Project																***
***	CEIS 400-0-0																***
***	October 2021 to December 2021												***
***																				***
**********************************************************************************/

/**********************************************************************************
***																				***
***	Scope:																		***
***	The purpose of this program is to automate the check-out and check-in		***
***	process of equipment and supplies from the equipment depot.	This application***
***	will track and record transactions between the depot and the requesting		***
***	technician.  As a result, the information will be recorded to allow for		***
***	tracking of equipment.  This will increase visiblity of equipment loss by	***
***	requestor.  Reports can be generated to identify trends by department and	***
***	technician.																	***
***																				***
**********************************************************************************/


#include <iostream>
#include <string.h>
#include "Equipment.h"
#include "Manager.h"
#include "Technician.h"

using namespace std;

int main(void){

	//Variable Declaration and Initialization


	//Connect to Database
	
	//User Input
	
	//Function Request : Check-out, Check-in, Technician Report, Manager Report
		//Select Function
			//Checkout:
				//Input Equipment Name
					//Search for Equipment Availability
					//Confirm Available and Condition
				//Enter Technician Name
					//Search for Technician by Number
					//Search for Technician by Last Name
						//Generate List
							//Select correct technician
				//Assign Equipment Number to Technician
				//Update Database
			
			//Check-in:
				//Input Employee Number
					//Query Database for employee record
				//Input Equipment Number
					//Enter returned condition
					//Enter usable (Y/N)
				//Update Database for returned equipment
		
			//Technician Reprt:
				//Input Employee Number
					//Query Database for employee record
						//Include equipment checked-out and recorded lost.
				//Display or Print record
					
			//Manager Report:
				//Input Manager Name
					//Query Database for employee by manager
				//Display or Print record

			//Update Database:
				//Input New Record
					//New Equipment
					//New Technician
					//New Manager

			//View Database:
				//View Records
					//by Technician
					//by Equipment
					//by Manager

	return 0;
}

