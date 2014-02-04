#include <iostream>
#include <string>
using namespace std;

int main(){
	double num1;
	double num2;
	double result;
	int keep_running;
	string cOP;
	bool programRunning = true;
	while (programRunning) {

		cout << "Welcome to my Smaxy Calculator" << endl;
		cout << "First number" << endl;
		cin >> num1;

		cout << num1;
		cout << "(operator) (number2) ";
		cout << "now type the opperator";
		cin >> cOP;

		cout << num1;
		cout << cOP;
		cout << "(number2)" << endl;
		cout << "now enter your second number";
		cin >> num2;

		if (cOP == "+"){
			double answer;
			answer = num1 + num2;
			cout << "The Answer is " << answer << "!" << endl;
			cout << "1 to do another calculation" << endl;
			cout << "2 to exit" << endl;
			cin >> keep_running;
			if (keep_running = 1){
				system("CLS");
				main();
			}
			if (keep_running = 2){
				return 0;
			}
		}
		if (cOP == "-"){
			double answer;
			answer = num1 - num2;
			cout << "The Answer is " << answer << "!" << endl;
			cout << "1 to do another calculation" << endl;
			cout << "2 to exit" << endl;
			cin >> keep_running;
			if (keep_running = 1){
				system("CLS");
				main();
			}
			if (keep_running = 2){
				return 0;
			}
		}
		if (cOP == "*"){
			double answer;
			answer = num1 * num2;
			cout << "The Answer is " << answer << "!" << endl;
			cout << "1 to do another calculation" << endl;
			cout << "2 to exit" << endl;
			cin >> keep_running;
			if (keep_running = 1){
				system("CLS");
				main();
			}
			if (keep_running = 2){
				return 0;
			}
		}
		if (cOP == "/"){
			double answer;
			answer = num1 / num2;
			cout << "The Answer is " << answer << "!" << endl;
			cout << "1 to do another calculation" << endl;
			cout << "2 to exit" << endl;
			cin >> keep_running;
			if (keep_running = 1){
				system("CLS");
				main();
			}
			else {

			}
		}
		system("CLS");
		cout << "Invalid opperator" << endl;
		main();
	}
}
