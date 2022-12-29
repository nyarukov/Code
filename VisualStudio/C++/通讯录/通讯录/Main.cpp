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
	cout << "**** 1.�����ϵ�� ****" << endl;
	cout << "**** 2.��ʾ��ϵ�� ****" << endl;
	cout << "**** 3.������ϵ�� ****" << endl;
	cout << "**** 4.ɾ����ϵ�� ****" << endl;
	cout << "**** 5.�޸���ϵ�� ****" << endl;
	cout << "**** 6.�����ϵ�� ****" << endl;
	cout << "******* 0.�˳� *******" << endl;
}

void Address (Addressbook* ads) {
	if (ads->n_size==MAX)
	{
		cout << "ͨѶ¼����" << endl;
		return;
	}
	else
	{

		cout << "����������" << endl;
		cin >> ads->Addressarr[ads->n_size].n_name;

		cout << " �������Ա� " << endl;
		cout << "1--�У�2--Ů" << endl;
		while (true)
		{
			int sex;
			cin >> sex;
			if (sex == 0 || sex > 2)
			{
				cout << "����������" << endl;
			}
			else
			{
				ads->Addressarr[ads->n_size].n_sex=sex;
				break;
			}
		}

		cout << "����������" << endl;
		while (true)
		{
			int age;
			cin >> age;
			if (age == 0 || age > 120)
			{
				cout << "����������" << endl;
			}
			else
			{
				ads->Addressarr[ads->n_size].n_age=age;
				break;
			}
		}
		cout << "������绰" << endl;
		cin >> ads->Addressarr[ads->n_size].n_phone;

		cout << "�������ַ" << endl;
		cin >> ads->Addressarr[ads->n_size].n_family;

		ads->n_size++;
		cout << "��ӳɹ�" << endl;

		system("pause");
		system("cls");
		return;
	};
}

void Addshow (Addressbook* ads) {
	if (ads->n_size==0)
	{
		cout << " ��ǰδ����κ���ϵ�ˣ�����" << endl;
	}
	else 
	{
		for (int i = 0; i < ads->n_size; i++)
		{
			cout << " ����: " << ads->Addressarr[i].n_name
				<< " �Ա�: " << (ads->Addressarr[i].n_sex == 1 ? "��" : "Ů")
				<< " ����: " << ads->Addressarr[i].n_age
				<< " �绰: " << ads->Addressarr[i].n_phone
				<< " ��ͥסַ: " << ads->Addressarr[i].n_family << endl;
		}
		
	}
	system("pause");
	system("cls");
	return;
}

void Addfind(Addressbook* ads) {
	string name;
	cout << "����������" << endl;
	cin >> name;

	for (int i = 0; i < ads->n_size; i++)
	{
		if (ads->Addressarr[i].n_name==name)
		{
			cout << " ����: " << ads->Addressarr[i].n_name
				<< " �Ա�: " << (ads->Addressarr[i].n_sex == 1 ? "��" : "Ů")
				<< " ����: " << ads->Addressarr[i].n_age
				<< " �绰: " << ads->Addressarr[i].n_phone
				<< " ��ͥסַ: " << ads->Addressarr[i].n_family << endl;

		}
		else {
			cout << "���޴���!!!" << endl;
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
		case 0: //�˳�
			return 0;
			break;
		case 1: //���
			Address(&ads);
			break;
		case 2: //��ʾ
			Addshow(&ads);
			break;
		case 3: //����
			Addfind(&ads);
			break;
		case 4: //ɾ��

			break;
		case 5: //�޸�
			break;
		case 6: //���
			break;
		default:
			break;
		}

	}
	system("pause");
}