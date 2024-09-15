import {EventEmitter} from 'fbemitter';
import { SERVER_GLOBAL } from '../../Configs/globals';
const SERVER = SERVER_GLOBAL+'/user'

class User{
    //starea initiala
    constructor(){
        this.data=[]
        this.emitter=new EventEmitter()
    }

    //metoda de signup
    async Signup(firstName,lastName,type,email,username,password){
        try{
            const response = await fetch(`${SERVER}/signup`,{
                method:'POST',
                headers:{
                    'Content-Type':'application/json'
                },
                body: JSON.stringify({firstName:firstName,lastName:lastName,type:type,email:email,username:username,passwordHash:password})
            })
            if(!response.ok){
                throw response
            }
            this.data=await response.json()
            this.emitter.emit('SIGNUP_SUCCESS')
        }
        catch(err){
            this.emitter.emit('SIGNUP_ERROR',await err.json())
        }
    }
}
const store = new User()

export default store 