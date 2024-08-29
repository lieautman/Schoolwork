const SERVER = 'http://localhost:8080'

export const GET_SPACECRAFT='GET_SPACECRAFT'
export const POST_SPACECRAFT='POST_SPACECRAFT'
export const DESTROY_SPACECRAFT='DESTROY_SPACECRAFT'
export const PUT_SPACECRAFT='PUT_SPACECRAFT'
export const EXPORT='EXPORT'
export const IMPORT='IMPORT'

export function getSpacecraft() {
  return {
    type: GET_SPACECRAFT,
    payload: async () => {
      const response = await fetch(`${SERVER}/spacecraft`);
      const data = await response.json();
      return data;
    },
  };
}

export function postSpacecraft(idSpacecraft,numeSpacecraft,vitezaMaximaSpacecraft,masaSpacecraft) {
  return {
    type: POST_SPACECRAFT,
    payload: async () => {
      let response = await fetch(`${SERVER}/spacecraft`,{
        method:'post',
        headers:{
            'Content-Type':'application/json'
        },
        body:JSON.stringify({id:idSpacecraft,nume:numeSpacecraft,vitezaMaxima:vitezaMaximaSpacecraft,masa:masaSpacecraft})
      })
      let data={message:'',spacecraftList:[]}
      data.message= await response.json()

      response = await fetch(`${SERVER}/spacecraft`);
      data.spacecraftList = await response.json();
      return data;
    },
  };
}

export function destroySpacecraft(idSpacecraftDelete) {
  return {
    type: POST_SPACECRAFT,
    payload: async () => {
      let response = await fetch(`${SERVER}/spacecraft/${idSpacecraftDelete}`,{
        method:'delete',
        headers:{
            'Content-Type':'application/json'
        },
        body:JSON.stringify()
      })
      let data={message:'',spacecraftList:[]}
      data.message= await response.json()

      response = await fetch(`${SERVER}/spacecraft`);
      data.spacecraftList = await response.json();
      return data;
    },
  };
}

export function putSpacecraft(idSpacecraftUpdateSelectat,numeSpacecraftUpdate,vitezaMaximaSpacecraftUpdate,masaSpacecraftUpdate) {
  return {
    type: PUT_SPACECRAFT,
    payload: async () => {
      let response = await fetch(`${SERVER}/spacecraft/${idSpacecraftUpdateSelectat}`,{
        method:'put',
        headers:{
            'Content-Type':'application/json'
        },
        body:JSON.stringify({nume:numeSpacecraftUpdate,vitezaMaxima:vitezaMaximaSpacecraftUpdate,masa:masaSpacecraftUpdate})
      })
      let data={message:'',spacecraftList:[]}
      data.message= await response.json()

      response = await fetch(`${SERVER}/spacecraft`);
      data.spacecraftList = await response.json();
      return data;
    },
  };
}

export function exportDB(){
  return {
    type: EXPORT,
    payload: async () => {
      let response = await fetch(`${SERVER}/export`,{
        method:'post',
        headers:{
            'Content-Type':'application/json'
        },
        body:JSON.stringify()
      })

      let data= await response.json()
      console.log(data)

      var dataStr = "data:text/json;charset=utf-8," + encodeURIComponent(JSON.stringify(data));
      var dlAnchorElem = document.getElementById('downloadAnchorElem');
      dlAnchorElem.setAttribute("href",     dataStr     );
      dlAnchorElem.setAttribute("download", "scene.json");
      dlAnchorElem.click();

      return data;
    },
  };
}
export function importDB(jsonDB){
  return {
    type: IMPORT,
    payload: async () => {
      let response = await fetch(`${SERVER}/import`,{
        method:'post',
        headers:{
            'Content-Type':'application/json'
        },
        body:JSON.stringify({spacecrafts:jsonDB.spacecrafts,astronauts:jsonDB.astronauts})
      })

      let data= await response.json()

      return data;
    },
  };
}