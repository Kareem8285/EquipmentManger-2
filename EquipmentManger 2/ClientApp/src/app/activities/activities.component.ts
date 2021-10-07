import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import { EquipmentservicesService } from '../equipmentservices.service';
import { Activity } from '../Activity';
import { activitySort } from '../activitySort';
@Component({
  selector: 'app-activities',
  templateUrl: './activities.component.html',
  styleUrls: ['./activities.component.css']
})
export class ActivitiesComponent implements OnInit {
  //needActivitylst: Array<Activity>;
  //myarray: Array<activitySort>;
  constructor(public serve: EquipmentservicesService) {
    this.serve.GetItesmsDataFromAPI();
  }

  ngOnInit() {
  }

}
