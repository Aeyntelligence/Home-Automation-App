void setup() {
  Serial.begin(9600);
  pinMode(7, OUTPUT);  // Light
  pinMode(8, OUTPUT);  // Fan
}

void loop() {
  if (Serial.available()) {
    char command = Serial.read();

    switch (command) {
      case 'A': digitalWrite(7, HIGH); break; // Light ON
      case 'a': digitalWrite(7, LOW); break;  // Light OFF
      case 'B': digitalWrite(8, HIGH); break; // Fan ON
      case 'b': digitalWrite(8, LOW); break;  // Fan OFF
    }
  }
}

