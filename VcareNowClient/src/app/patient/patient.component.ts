import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { error } from '@angular/compiler/src/util';

@Component({
  selector: 'app-patient',
  templateUrl: './patient.component.html',
  styleUrls: ['./patient.component.css']
})
export class PatientComponent implements OnInit {
  values: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getPatientData();
  }

  getPatientData() {
    this.http.get('http://localhost:49227/api/Patient/').subscribe(response => {
      this.values = Response;
    }, errormesg => {
        console.log(errormesg);
    });
  }
}
