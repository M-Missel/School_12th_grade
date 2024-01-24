#include <iostream>
#include <string>

class Person{
    protected:
        std::string name;
        int age;

    public:
        Person(std::string name, int age){
            this->name = name;
            this->age = age;
        }

        std::string getName(){
            return name;
        }

        int getAge(){
            return age;            
        }
};

class Student : public Person{
    private:
        std::string stdClass;
    
    public:
        Student(std::string name, int age, std::string stdClass) : Person(name, age){
            this->stdClass = stdClass;
        }

        std::string getStdClass(){
            return stdClass;
        }
};

class Teacher : public Person{
    private:
        std::string subject;
    
    public:
        Teacher(std::string name, int age, std::string subject) : Person(name, age){
            this->subject = subject;
        }

        std::string getSubject(){
            return subject;
        }
};

int main(){
    Person person("Moritz", 21);
    Student student("Niklas", 15, "Chemistry");
    Teacher teacher("Ernst", 51, "ITS");

    std::cout << person.getAge() << "\t" << student.getStdClass() << "\t" << teacher.getSubject() << std::endl;

    return 0;
}