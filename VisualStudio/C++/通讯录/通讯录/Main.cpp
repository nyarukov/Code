#include <iostream>
#include<string>
using namespace std;
#define MAX 100

struct Person {
	string n_name;
	int n_sex;
	int n_age;
	int n_phone;
	string n_family;
};

struct Addressbook {
	struct Person Addressarr[MAX];
	int n_size;
};

void start() {
	cout << "********************" << endl;
	cout << "**** 1.添加联系人 ****" << endl;
	cout << "**** 2.显示联系人 ****" << endl;
	cout << "**** 3.查找联系人 ****" << endl;
	cout << "**** 4.删除联系人 ****" << endl;
	cout << "**** 5.修改联系人 ****" << endl;
	cout << "**** 6.清空联系人 ****" << endl;
	cout << "******* 0.退出 *******" << endl;
}

void Address (Addressbook* ads) {
	if (ads->n_size==MAX)
	{
		cout << "通讯录已满" << endl;
		return;
	}
	else
	{

		cout << "请输入姓名" << endl;
		cin >> ads->Addressarr[ads->n_size].n_name;

		cout << " 请输入性别 " << endl;
		cout << "1--男，2--女" << endl;
		while (true)
		{
			int sex;
			cin >> sex;
			if (sex == 0 || sex > 2)
			{
				cout << "请重新输入" << endl;
			}
			else
			{
				ads->Addressarr[ads->n_size].n_sex=sex;
				break;
			}
		}

		cout << "请输入年龄" << endl;
		while (true)
		{
			int age;
			cin >> age;
			if (age == 0 || age > 120)
			{
				cout << "请重新输入" << endl;
			}
			else
			{
				ads->Addressarr[ads->n_size].n_age=age;
				break;
			}
		}
		cout << "请输入电话" << endl;
		cin >> ads->Addressarr[ads->n_size].n_phone;

		cout << "请输入地址" << endl;
		cin >> ads->Addressarr[ads->n_size].n_family;

		ads->n_size++;
		cout << "添加成功" << endl;

		system("pause");
		system("cls");
		return;
	};
}

void Addshow (Addressbook* ads) {
	if (ads->n_size==0)
	{
		cout << " 当前未添加任何联系人！！！" << endl;
	}
	else 
	{
		for (int i = 0; i < ads->n_size; i++)
		{
			cout << " 姓名: " << ads->Addressarr[i].n_name
				<< " 性别: " << (ads->Addressarr[i].n_sex == 1 ? "男" : "女")
				<< " 年龄: " << ads->Addressarr[i].n_age
				<< " 电话: " << ads->Addressarr[i].n_phone
				<< " 家庭住址: " << ads->Addressarr[i].n_family << endl;
		}
		
	}
	system("pause");
	system("cls");
	return;
}

void Addfind(Addressbook* ads) {
	string name;
	cout << "请输入姓名" << endl;
	cin >> name;

	for (int i = 0; i < ads->n_size; i++)
	{
		if (ads->Addressarr[i].n_name==name)
		{
			cout << " 姓名: " << ads->Addressarr[i].n_name
				<< " 性别: " << (ads->Addressarr[i].n_sex == 1 ? "男" : "女")
				<< " 年龄: " << ads->Addressarr[i].n_age
				<< " 电话: " << ads->Addressarr[i].n_phone
				<< " 家庭住址: " << ads->Addressarr[i].n_family << endl;

		}
		else {
			cout << "查无此人!!!" << endl;
		}
	}
	system("pause");
	system("cls");
	return;
}



int main() {

	Addressbook ads;
	ads.n_size = 0;
	int choose = 0;

	while (true)
	{
		start();
		
		cin >> choose;
		switch (choose)
		{
		case 0: //退出
			return 0;
			break;
		case 1: //添加
			Address(&ads);
			break;
		case 2: //显示
			Addshow(&ads);
			break;
		case 3: //查找
			Addfind(&ads);
			break;
		case 4: //删除

			break;
		case 5: //修改
			break;
		case 6: //清空
			break;
		default:
			break;
		}

	}
	system("pause");
}