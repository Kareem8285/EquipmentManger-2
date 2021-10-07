import { Component, Inject, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { EquipmentservicesService } from '../equipmentservices.service';
import * as $ from "jquery";
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-set-activity',
  templateUrl: './set-activity.component.html',
  styleUrls: ['./set-activity.component.css']
})
export class SetActivityComponent implements OnInit {
  sub: Subscription | undefined;
  Eqitem: any;
  url: string = '';
  constructor(public serve: EquipmentservicesService, private route: ActivatedRoute, private _router: Router, private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.url = baseUrl
    this.serve.GetItesmsDataFromAPI();
  }
  ngOnInit() {
    this.sub = this.route.paramMap.subscribe(params => {
      let id = params.get("id");
      this.Eqitem = this.serve.Activitylst.filter(a => a.equipmentItemsId.toString() === id)[0];
    })
  }
  Savedata(x: number, y: any) {
    let SavedData = {
      equipmentItemsId: x,
      record_reading: parseInt(y.value)
    }
//// post data to api
$.ajax({
  type: "POST",
  url: this.url +'api/ActionStateApi',
  data: JSON.stringify(SavedData),// now data come in this function
  contentType: "application/json; charset=utf-8",
  crossDomain: true,
  dataType: "json",
  success: function (data, status, jqXHR) {
      alert("success");// write success in " " 
  },
  error: function (jqXHR, status) {
      // error handler
      console.log(jqXHR);
 //     alert('faile' + status.code);
  }
});
//// post data to api
this.serve.GetItesmsDataFromAPI();
this._router.navigate(['Activities'])
  }
}
