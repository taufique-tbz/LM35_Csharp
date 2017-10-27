byte inputByte_0;
byte inputByte_1;
byte inputByte_2;

float tempC;
int reading;
int tempPin = 0;

void setup() {
  Serial.begin(9600);
  analogReference(INTERNAL);
}
void loop() {  
  if (Serial.available()> 2) 
  {
    inputByte_0 = Serial.read();
    delay(10);    
    inputByte_1 = Serial.read();
    delay(10);      
    inputByte_2 = Serial.read();
    delay(10);   
  }
  if(inputByte_0 == 4)
  {       
       switch (inputByte_1) 
       {
          case 8:
             switch (inputByte_2)
            {
              case 16:
                Serial.print("I'M ARDUINO");
                break;
              case 32: 
                  reading = analogRead(tempPin);
                  tempC = reading / 9.31;
                  Serial.print(tempC);
                  Serial.println();
                  Serial.print((tempC * 9)/5 + 32); 
                  break;
            }
        } 
        inputByte_0 = 0;
        inputByte_1 = 0;
        inputByte_2 = 0;
  }
}
