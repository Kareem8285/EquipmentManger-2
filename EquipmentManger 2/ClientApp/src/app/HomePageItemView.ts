export class HomePageItemView{
    constructor(public  equipmentId:number, public  EquipmentName:string,public categoryName:string, public EquipmentSerialno:string, public eqcapacity:string,public eqlocation:string)     
    {
        this.equipmentId=equipmentId;
        this.EquipmentName=EquipmentName;
        this.categoryName=categoryName;
        this.EquipmentSerialno=EquipmentSerialno;
        this.eqcapacity=eqcapacity;
        this.eqlocation=eqlocation;      
    }
}

