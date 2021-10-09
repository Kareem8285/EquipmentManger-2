export class Activity {
    constructor(public equipmentId: number, public itemId: number, public equipmentName: string, public equipmentSerialno: string, public itemName: string, public itemPartNo: string, public mintenanceState: number, public equipmentItemsId: number,public lastMinH:number) {
        this.equipmentId = equipmentId;
        this.itemId = itemId;
        this.equipmentName = equipmentName;
        this.equipmentSerialno = equipmentSerialno;
        this.itemName = itemName;
        this.itemPartNo = itemPartNo;
        this.mintenanceState = mintenanceState;
        this.equipmentItemsId = equipmentItemsId;
        this.lastMinH=lastMinH;

    }
}

