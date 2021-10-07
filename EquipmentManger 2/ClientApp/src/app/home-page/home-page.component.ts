import { Component, OnInit } from '@angular/core';
import { EquipmentservicesService } from '../equipmentservices.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit {

  constructor(public serve: EquipmentservicesService) {
    this.serve.GetItesmsDataFromAPI();
    //this.serve.fn2();
  }

  ngOnInit() {
    this.serve.Filtered_Eq_by_category('All Equipments');
  //  console.log(this.serve.HomepageList);
  }

}
