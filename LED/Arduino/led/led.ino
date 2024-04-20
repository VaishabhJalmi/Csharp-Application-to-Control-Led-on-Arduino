
// Electronicscuriosities.com

String val;        // variable to store data
void setup(){
    Serial.begin(9600);
    pinMode(13,OUTPUT);
}
void loop(){

    if(Serial.available()){           //serial port check
        val = Serial.readString();
    }
    if(val=="ON"){                     // Led ON when button Click
        digitalWrite(13,HIGH);
    }
    else if(val=="OFF"){                // Led OFF when button Click
        digitalWrite(13,LOW);
    }
}
