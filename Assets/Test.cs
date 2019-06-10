using UnityEngine;
using System.Collections;

public class Boss {
        private int hp = 100;          // 体力
        private int power = 25; // 攻撃力
		private int mp = 53; 	//課題：int型の変数mpを宣言し、53で初期化してください


        // 攻撃用の関数
        public void Attack() { 
                Debug.Log( this.power + "のダメージを与えた" );
        }
		//課題：mpを消費して魔法攻撃をするMagic関数を作ってください
        public void MpAttack() { 
				//Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。
                this.mp-=5;
				if(mp<0){
					Debug.Log("MPが足りないため魔法が使えない。");
				}else{
					Debug.Log("魔法攻撃をした。残りMPは"+this.mp+"。");
				}
				
        }		

        // 防御用の関数
        public  void Defence(int damage) { 
                Debug.Log( damage+"のダメージを受けた" );
                // 残りhpを減らす
                this.hp -= damage;
        }

}

public class Test : MonoBehaviour {        
		//課題：要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
		int[] array_test = {10,20,30,40,50};

        void Start () {

			//課題：for文を使い、配列の各要素の値を順番に表示してください
			Debug.Log("課題：for文を使い、配列の各要素の値を順番に表示してください");
			for(int i=0;i<array_test.Length;i++){
				Debug.Log("Array "+i+" is "+array_test[i]);
			}
			//課題：for文を使い、配列の各要素の値を逆順に表示してください
			Debug.Log("課題：for文を使い、配列の各要素の値を逆順に表示してください");
			for(int i=array_test.Length-1;i>=0;i--){
				Debug.Log("Array "+i+" is "+array_test[i]);
			}			
            // Bossクラスの変数を宣言してインスタンスを代入
            Boss lastboss = new Boss ();

			Debug.Log("課題：int型の変数mpを宣言し、53で初期化してください");
            // 攻撃用の関数を呼び出す
            //lastboss.Attack();
            // 防御用の関数を呼び出す
            //lastboss.Defence(3);
			//課題：Magic関数を呼び出して、魔法を使ってください
			lastboss.MpAttack();
			//Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認してください
			for(int i=0;i<10;i++){
				lastboss.MpAttack();
			}
			
			//
        }
        
        // Update is called once per frame
        void Update () {
        
        }
}