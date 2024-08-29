const SERVER = 'http://localhost:8080'

export const GET_ASTROANUT='GET_ASTROANUT'
export const POST_ASTROANUT='POST_ASTROANUT'
export const PUT_ASTROANUT='POST_ASTROANUT'
export const DESTROY_ASTROANUT='DESTROY_ASTROANUT'

export function getAstronaut(idSpacecraft) {
  return {
    type: GET_ASTROANUT,
    payload: async () => {
      const response = await fetch(`${SERVER}/astronaut/${idSpacecraft}`);
      const data = await response.json();
      return data;
    },
  };
}


export function postAstronaut(idSpacecraftPtAstronatui, idAstronaut, numeAstronaut, rolAstronaut) {
  return {
    type: POST_ASTROANUT,
    payload: async () => {
      let response = await fetch(`${SERVER}/astronaut/${idSpacecraftPtAstronatui}`,{
        method:'post',
        headers:{
            'Content-Type':'application/json'
        },
        body:JSON.stringify({id:idAstronaut,nume:numeAstronaut,rol:rolAstronaut})
      })
      let data={message:'',astronautList:[]}
      data.message= await response.json()


      response = await fetch(`${SERVER}/astronaut/${idSpacecraftPtAstronatui}`);
      data.astronautList =await response.json();
      return data;
    },
  };
}

export function putAstronaut(idSpacecraftPtAstronatui,idAstronautUpdateSelectat, numeAstronautUpdate, rolAstronautUpdate) {
  return {
    type: PUT_ASTROANUT,
    payload: async () => {
      let response = await fetch(`${SERVER}/astronaut/${idSpacecraftPtAstronatui}/${idAstronautUpdateSelectat}`,{
        method:'put',
        headers:{
            'Content-Type':'application/json'
        },
        body:JSON.stringify({nume:numeAstronautUpdate,rol:rolAstronautUpdate})
      })
      let data={message:'',astronautList:[]}
      data.message= await response.json()

      response = await fetch(`${SERVER}/astronaut/${idSpacecraftPtAstronatui}`);
      data.astronautList = await response.json();
      return data;
    },
  };
}


export function destroyAstronaut(idSpacecraftPtAstronatui,idAstronautUpdateSelectat) {
  return {
    type: DESTROY_ASTROANUT,
    payload: async () => {
      let response = await fetch(`${SERVER}/astronaut/${idSpacecraftPtAstronatui}/${idAstronautUpdateSelectat}`,{
        method:'delete',
        headers:{
            'Content-Type':'application/json'
        },
        body:JSON.stringify()
      })
      let data={message:'',astronautList:[]}
      data.message= await response.json()

      response = await fetch(`${SERVER}/astronaut/${idSpacecraftPtAstronatui}`);
      data.astronautList = await response.json();
      console.log(data)
      return data;
    },
  };
}