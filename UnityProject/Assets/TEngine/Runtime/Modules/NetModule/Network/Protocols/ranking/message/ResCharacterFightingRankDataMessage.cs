using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 最强角色榜数据 message
 */
public class ResCharacterFightingRankDataMessage : Message 
{
	//最强角色榜列表
	List<CharacterFightingRankBean> _characterFightingRankBean = new List<CharacterFightingRankBean>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//最强角色榜列表
		SerializeUtils.WriteShort(stream, (short)_characterFightingRankBean.Count);

		foreach (var element in _characterFightingRankBean)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//最强角色榜列表
		int _characterFightingRankBean_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characterFightingRankBean_length; ++i) 
		{
			_characterFightingRankBean.Add(SerializeUtils.ReadBean<CharacterFightingRankBean>(stream));
		}
	}
	
	/**
	 * get 最强角色榜列表
	 * @return 
	 */
	public List<CharacterFightingRankBean> GetCharacterFightingRankBean()
	{
		return _characterFightingRankBean;
	}
	
	/**
	 * set 最强角色榜列表
	 */
	public void SetCharacterFightingRankBean(List<CharacterFightingRankBean> characterFightingRankBean)
	{
		_characterFightingRankBean = characterFightingRankBean;
	}
	
	
	public override int GetId() 
	{
		return 209104;
	}
}