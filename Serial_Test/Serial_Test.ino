int count = 0;
unsigned long previousMillis = 0;
const long interval = 1000;

void setup() {
  Serial.begin(115200);
}
void loop() {
  unsigned long currentMillis = millis();

  if(Serial.available()>0){
    Serial.println("Back: "+Serial.readString());
  }

  if (currentMillis - previousMillis >= interval) {
    previousMillis = currentMillis;
    Serial.println("Ping: "+String(count));
    count++;
  }
}
