#include <iostream>
#include <string>

using namespace std;

double anum, anum1, ans;
string  aop;
double add(double num1, double num2){
	return num1 + num2;
}
double sub(double num1, double num2){
	return num1 - num2;
}
double mult(double num1, double num2){
	return num1 * num2;
}
double div(double num1, double num2){
	return num1 / num2;
}
/*int check(int va){
	int value(0);
	while (!(va >> value)) {
		std::cout << "you entered a non-digit character\n";
		std::cin.clear();   // make sure that std::cin is happy to do something
		std::cin.ignore();  // ignore the offending character
	}
	return 1;
}*/
/*int read(){
	int c;
	int a;
	do {
		c = getchar();
		putchar(c);
	} while (!(a >> 0));
	return c;
}*/
int main(){
//	double num1, num2, answer;
	int con(0);
	aop = "#";
	anum = 0;
	anum1 = 0;
	double answer(0);
	string op;
	
	while (con < 3){
		system("CLS");
		cout << anum << " " << aop << " " << anum1 << "=" << answer << endl;
		if (con == 0){
			cin >> anum;
		}
		if (con == 1){
			cin >> aop;;
		}
		if (con == 2){
			cin >> anum1;
		}
		con += 1;
	}

	if (aop == "+"){
		answer = add(anum, anum1);
	}
	if (aop == "-"){
		answer = sub(anum, anum1);
	}
	if (aop == "*" || op == "x"){
		answer = mult(anum, anum1);
	}
	if (aop == "/"){
		answer = div(anum, anum1);
	}
	system("CLS");
	cout << anum << " " << aop << " " << anum1 << "=" << answer << endl;
	cout << "Press any Key to Restart" << endl;
	string restart;
	cin >> restart;
	main();
}

