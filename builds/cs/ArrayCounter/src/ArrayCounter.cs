// Generated by Haxe 4.3.1

#pragma warning disable 109, 114, 219, 429, 168, 162
public class ArrayCounter : global::haxe.lang.HxObject {
	
	public static void Main(){
		global::cs.Boot.init();
		global::ArrayCounter.main();
	}
	public ArrayCounter(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public ArrayCounter() {
		global::ArrayCounter.__hx_ctor__ArrayCounter(this);
	}
	
	
	protected static void __hx_ctor__ArrayCounter(global::ArrayCounter __hx_this) {
	}
	
	
	public static void main() {
		unchecked {
			global::Array<int> _g = new global::Array<int>(new int[]{});
			{
				int _g1 = 0;
				while (( _g1 < 100 )) {
					int i = _g1++;
					if (( ( i % 2 ) == 0 )) {
						_g.push(i);
					}
					
				}
				
			}
			
			global::Array<int> evenNumber = _g;
			{
				int _g2 = 0;
				while (( _g2 < evenNumber.length )) {
					int num = evenNumber[_g2];
					 ++ _g2;
					global::haxe.Log.trace.__hx_invoke2_o(((double) (num) ), global::haxe.lang.Runtime.undefined, default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "ArrayCounter", "ArrayCounter.hx"}, new int[]{1981972957}, new double[]{((double) (6) )}));
				}
				
			}
			
		}
	}
	
	
}


