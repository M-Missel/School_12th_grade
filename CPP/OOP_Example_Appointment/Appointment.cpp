#include <string>

class Appointment{
    private:
        bool _repeat;
        bool _reminder;
        std::string _topic;
        std::string _location;

    public:
        Appointment(std::string _topic, std::string _location){
            this->_topic = _topic;
            this->_location = _location;
        }

        void setRepeat(bool _repeat){
            this->_repeat = _repeat;
        }

        bool getRepeat(){
            return _repeat;
        }

        void setReminder(bool _reminder){
            this->_reminder = _reminder;
        }

        bool getReminder(){
            return _reminder;
        }

        void setTopic(std::string _topic){
            this->_topic = _topic;
        }

        std::string getTopic(){
            return _topic;
        }

        void setLocation(std::string _location){
            this->_location = _location;
        }

        std::string getLocation(){
            return _location;
        }
};