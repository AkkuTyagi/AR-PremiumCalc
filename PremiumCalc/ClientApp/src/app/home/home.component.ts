import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  public personName = "";
  public personAge = "";
  public personDob = "";
  public sumInsured = "";
  public personOccupation = "";
  public premium = 0;

  public occupations;
  public ratings = [
    { Factor: 1.0, Rating: "Professional" },
    { Factor: 1.25, Rating: "White Collar" },
    { Factor: 1.50, Rating: "Light Manual" },
    { Factor: 1.75, Rating: "Heavy Manual" },
  ];

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http.get("/premiumCalc").subscribe(response => {
      this.occupations = response;
    })
  }

  public onOccupationChange() {
    var ratingFactor = this.ratings.filter(x => x.Rating === this.personOccupation);
    this.premium = (parseInt(this.sumInsured) * ratingFactor[0].Factor * parseInt(this.personAge)) / 1000 * 12;
  }

}
